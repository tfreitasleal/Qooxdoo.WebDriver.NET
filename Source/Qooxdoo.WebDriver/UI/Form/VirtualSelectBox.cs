﻿/*************************************************************************

   qxwebdriver-java

   http://github.com/qooxdoo/qxwebdriver-java

   Copyright:
     2012-2013 1&1 Internet AG, Germany, http://www.1und1.de

   License:
     LGPL: http://www.gnu.org/licenses/lgpl.html
     EPL: http://www.eclipse.org/org/documents/epl-v10.php
     See the license.txt file in the project's top-level directory for details.

   Authors:
     * Daniel Wagner (danielwagner)

*************************************************************************/

using OpenQA.Selenium;

namespace Qooxdoo.WebDriver.UI.Form
{
    /// <summary>
    /// Represents a <a href="http://demo.qooxdoo.org/current/apiviewer/#qx.ui.form.VirtualSelectBox">VirtualSelectBox</a>
    /// widget
    /// </summary>
    public class VirtualSelectBox : SelectBox
    {
        public VirtualSelectBox(IWebElement element, QxWebDriver driver) : base(element, driver)
        {
        }

        protected internal override ISelectable List
        {
            get
            {
                if (list == null)
                {
                    IWidget dropdown = WaitForChildControl("dropdown", 3);
                    list = (ISelectable) dropdown.GetChildControl("list");
                }
                return list;
            }
        }
    }
}