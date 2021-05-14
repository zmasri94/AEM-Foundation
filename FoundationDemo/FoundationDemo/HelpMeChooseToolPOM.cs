using HRBlock.CTF.UI;
using HRBlock.CTF;
using System;
using System.Diagnostics;
using HRBlock.CTF.UI.Web;

namespace FoundationDemo
{
    [WebUIScope("AEM")]
    public class HelpMeChooseToolPOM : WebPageObjectModel
    {

        //Page Buttons
        public IElement HelpMeChoose => GetElement("HelpMeChoose", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[text()='Help me choose']")));


        public IElement OneOnone => GetElement("OneOnone", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']")));
        public IElement ValidateButton => GetElement("ValidateButton", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-header='productButton']")));
        public IElement ContinueBtn => GetElement("ContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id='di-id-41fd44f0-7c1e7578']")));

        //How much Help Would you like?
         public IElement ProDoesAll => GetElement("ProDoesAll", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']")));
        public IElement HelpFromPro => GetElement("HelpFromPro", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']")));
        public IElement DoOwnTaxes => GetElement("DoOwnTaxes", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '3']")));
        public IElement HelpContinueBtn => GetElement("HelpContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id='di-id-e2accf9f-71c3ff4']")));


        //What was your Employment Status?
        public IElement Student => GetElement("Student", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[text()='W-2, student, retired,or unemployed']")));
        public IElement ContractAndFreelance => GetElement("ContractAndFreelance", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[text()='Freelance, contract, or gig work']")));
        public IElement SelfEmployed => GetElement("SelfEmployed", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[text()='Self-employed']")));


        //How much help would you like?
        public IElement MeetVirtually => GetElement("MeetVirtually", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']")));
        public IElement IWantToSendInDocs => GetElement("IWantToSendInDocs", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']")));
        public IElement BringToLocalOffice => GetElement("BringToLocalOffice", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']")));
        public IElement MeetInPerson => GetElement("MeetInPerson", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']")));


        //Eraned income?
        public IElement EarnedIncome => GetElement("EarnedIncome", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']", 1000)));
        public IElement NoEarnedIncome => GetElement("NoEarnedIncome", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']", 1000)));
        public IElement EarnedIncomeContinueBtn => GetElement("EarnedIncomeContinueBtn", () => ElementBuilder.Button(SelectorBuilder.XPath("//a[@data-di-id='di - id - e2accf9f - 6118eac4']")));
        //Earn income from investments or rental properties last year?


        //Did you have an HSA last year
        public IElement YesHSA => GetElement("YesHSA", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']", 1000)));
        public IElement NoHSA => GetElement("NoHSA", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '2']", 1000)));


        //Do you Have a Business Expense?
        public IElement YesBusinessExpense => GetElement("YesBusinessExpense", () => ElementBuilder.Button(SelectorBuilder.XPath("//label[@for = '1']", 1000)));
    }


}
