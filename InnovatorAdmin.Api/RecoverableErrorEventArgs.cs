﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Innovator.Client;

namespace Aras.Tools.InnovatorAdmin
{
  public class RecoverableErrorEventArgs : EventArgs
  {
    public string Message { get; set; }
    public ServerException Exception { get; set; }
    public XmlNode NewQuery { get; set; }
    public RecoveryOption RecoveryOption { get; set; }

    public RecoverableErrorEventArgs()
    {
      this.RecoveryOption = RecoveryOption.Abort;
    }
  }
}
