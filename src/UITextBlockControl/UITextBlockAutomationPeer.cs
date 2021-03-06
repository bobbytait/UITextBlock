﻿using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace CCWin.App.Infrastructure.Controls
{
    public class UITextBlockAutomationPeer : TextBlockAutomationPeer
    {
        public UITextBlockAutomationPeer(TextBlock owner) : base(owner)
        {
        }

        protected override bool IsControlElementCore()
        {
            return true;
        }
    }
}