using HRBlock.CTF.UI;
using HRBlock.CTF;
using System;
using System.Diagnostics;
using HRBlock.CTF.UI.Web;

namespace FoundationDemo
{
    [WebUIScope("TaxSoftware")]
    public class TaxSoftwarePOM : WebPageObjectModel
    {
        //Generic Continue
        public IElement ContinueBtn => GetElement("ContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id= 'di-id-73dca254-8164f08f']")));


        //Page Buttons
        public IElement HelpMeChoose => GetElement("HelpMeChoose", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[text()='Help me choose']")));

        public IElement ValidateButton => GetElement("ValidateButton", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-header='productButton']")));


        //What was your Employment Status?
        public IElement Retired => GetElement("Retired", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[text()= 'W-2, retirement, or unemployment']")));
        public IElement SelfEmployed => GetElement("SelfEmployed", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[text()='Self-employed or Rental income']")));
        public IElement OwnABusiness => GetElement("OwnABusiness", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[text()='Own a business']")));
        public IElement EmploymentStatusContinueBtn => GetElement("EmploymentStatusContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id='di-id-e2accf9f-71c3ff4']")));

        //Do you have investments or want to itemize deductions
        public IElement YesItemizedDeductions => GetElement("YesItemizedDeductions", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']", 1000)));
        public IElement NoItemizedDeductions => GetElement("NoItemizedDeductions", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']", 1000)));
        public IElement ItemizedDeductionsContinueBtn => GetElement("ItemizedDeductionsContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id= 'di-id-73dca254-e76025bf']")));


        //Do you have Need to file State Taxes
        public IElement YesFileStateTaxes => GetElement("YesFileStateTaxes", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']", 1000)));
        public IElement NoFileStateTaxes => GetElement("NoFileStateTaxes", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']", 1000)));
        public IElement FileStateTaxesContinueBtn => GetElement("FileStateTaxesContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id= 'di-id-73dca254-c56396af']")));

    }
}
