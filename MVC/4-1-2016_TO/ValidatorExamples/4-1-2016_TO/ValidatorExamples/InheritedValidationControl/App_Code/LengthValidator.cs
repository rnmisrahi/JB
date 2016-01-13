using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ValidationLibrary
{
    /// <summary>
    /// Summary description for LengthValidator
    /// </summary>
    public class LengthValidator : BaseValidator
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        protected override bool EvaluateIsValid()
        {
            string value = this.GetControlValidationValue(this.ControlToValidate);
            if (value.Length > MaxLength || value.Length < MinLength)
                return false;
            else
                return true;
        }

        protected override void OnPreRender(EventArgs e)
        {
            // Check if client supports and enables javascript
            if (this.DetermineRenderUplevel() && this.EnableClientScript)
            {

                Page.ClientScript.RegisterClientScriptBlock(GetType(), "JSScript",
                    "<script type=text/javascript src='LengthValidation.js'>" +
                        "</script>");
                Page.ClientScript.RegisterExpandoAttribute(this.ClientID, "evaluationfunction", "evalf");
            }
            base.OnPreRender(e);
        }

        //protected override void OnPreRender(EventArgs e)
        //{
        //    if (this.DetermineRenderUplevel() && this.EnableClientScript)
        //    {

        //        Page.ClientScript.RegisterClientScriptBlock(GetType(), "JSScript",
        //            "<script type=text/javascript>function evalf(val) " +
        //                "{ " +
        //                    " // alert(val.controltovalidate);\n" +
        //                    " var length = document.all ? document.all[val.controltovalidate].value.length : document.getElementById(val.controltovalidate).value.length;" +
        //                    " // alert(length);\n " +
        //                    " if (length<4 || length>8)" +
        //                    "       return false;" +
        //                    " return true; " +
        //                "}</script>");
        //        Page.ClientScript.RegisterExpandoAttribute(this.ClientID, "evaluationfunction", "evalf");
        //    }
        //    base.OnPreRender(e);
        //}
    }
}
