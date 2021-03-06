﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace InnovatorAdmin.Controls
{
  public partial class ProgressStep<T> : UserControl, IWizardStep, IProgessStep where T : IProgressReporter
  {
    private T _progress;
    private IWizard _wizard;
    private System.Windows.Forms.Timer _clock = new System.Windows.Forms.Timer();
    private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
    private bool _unlinked = false;
    private DateTime _start = DateTime.UtcNow;

    public Action<T> MethodInvoke { get; set; }
    public Action GoNextAction { get; set; }

    public ProgressStep(T progress)
    {
      InitializeComponent();
      _progress = progress;
      _progress.ActionComplete += _progress_ActionComplete;
      _progress.ProgressChanged += _progress_ProgressChanged;
      btnCancel.Visible = _progress is ICancelableProgressReporter;

      _timer.Interval = 50;
      _timer.Tick += _timer_Tick;

      _clock.Interval = 250;
      _clock.Tick += _clock_Tick;
      _clock.Enabled = true;

      GlobalProgress.Instance.Start();
    }

    void _clock_Tick(object sender, EventArgs e)
    {
      lblTime.Text = (DateTime.UtcNow - _start).ToString(@"hh\:mm\:ss");
    }

    private void UnLink()
    {
      if (!_unlinked)
      {
        _unlinked = true;
        _progress.ActionComplete -= _progress_ActionComplete;
        _progress.ProgressChanged -= _progress_ProgressChanged;
      }
    }

    void _timer_Tick(object sender, EventArgs e)
    {
      GlobalProgress.Instance.Stop();
      UnLink();
      this.GoNextAction();
      _timer.Enabled = false;
    }

    void _progress_ActionComplete(object sender, ActionCompleteEventArgs e)
    {
      this.UiThreadInvoke(() =>
      {
        if (e.Exception == null)
        {
          _timer.Enabled = true;
        }
        else
        {
          lblMessage.Text = "ERROR: " + e.Exception.Message;
          Utils.HandleError(e.Exception);
          GlobalProgress.Instance.Error();
        }
      });
    }

    void _progress_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      if (this.Parent != null)
      {
        this.UiThreadInvoke(() =>
        {
          progBar.Value = e.Progress;
          lblMessage.Text = e.Message ?? lblMessage.Text;
          GlobalProgress.Instance.Value(e.Progress);
        });
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      var _background = new Thread(o => this.MethodInvoke(_progress));
      _background.Start();
    }

    public void Configure(IWizard wizard)
    {
      _wizard = wizard;
      _wizard.NextEnabled = false;
    }

    public void GoNext()
    {
      throw new NotImplementedException();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      try
      {
        ((ICancelableProgressReporter)_progress).Cancel = true;
      }
      catch (Exception ex)
      {
        Utils.HandleError(ex);
      }
    }
  }
}
