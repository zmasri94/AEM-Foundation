using FoundationDemo;
using HRBlock.CTF;
using HRBlock.CTF.UI;
using HRBlock.CTF.UI.Web;


namespace FoundationDemo
{
    public class HelpMeChoose
    {
       
        //file with tax pro virtually
        [UITest, HRBlock.CTF.Scope("AEM")]
        public void FileWithTaxProVirtually(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {

            url.Name = "https://hrbcomlnp.hrblock.com/tax-offices/virtual-tax-preparation/";
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.ProDoesAll);
            driver.Action.Click(pom.ContinueBtn);
            wait.UntilVisible(pom.MeetVirtually, 8, 1000);
            driver.Action.Click(pom.MeetVirtually);
            driver.Action.Click(pom.HowMuchHelpContinueBtn);
            driver.Action.Click(pom.IWantToSendInDocs);
            driver.Action.Click(pom.SendDocsContinueBtn);

            wait.UntilVisible(pom.ValidateButton);
            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

        //drop off
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(FileWithTaxProVirtually))]
        public void FileWithTaxProDropOff(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)

        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            url.Name = "https://hrbcomlnp.hrblock.com/tax-offices/drop-off/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.ProDoesAll);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.MeetVirtually);
            driver.Action.Click(pom.HowMuchHelpContinueBtn);
            driver.Action.Click(pom.BringToLocalOffice);
            driver.Action.Click(pom.SendDocsContinueBtn);

            wait.UntilVisible(pom.ValidateButton);


            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }

        //meet in office
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(FileWithTaxProDropOff))]

        public void MeetInOffice(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            url.Name = "https://hrbcomlnp.hrblock.com/tax-offices/office-tax-preparation/";
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.ProDoesAll);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.MeetInPerson);
            driver.Action.Click(pom.HowMuchHelpContinueBtn);
            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

   
        }
        //Basic/free Online Package
        [UITest, HRBlock.CTF.Scope("AEM")]
        //[DependsOn(typeof(HelpMeChoose), nameof(MeetInOffice))]
        public void FreeOnline(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/free-online-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            wait.UntilVisible(pom.DoOwnTaxes);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.HelpContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);
            driver.Action.Click(pom.NoHSA);
            driver.Action.Click(pom.HSAContinueBtn);

            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }
      
        //Deluxe Online without state

            //Deluxe online 1/3
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(FreeOnline))]
        public void DeluxeOnlineStudent(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/deluxe-online-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.ContractAndFreelance);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);


            wait.UntilVisible(pom.ValidateButton);



            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

        //deluxe online 2/3

        [UITest, HRBlock.CTF.Scope("AEM")]
        public void DeluxeOnlineFreelanceWorker(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/deluxe-online-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.ContractAndFreelance);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);


            wait.UntilVisible(pom.ValidateButton);



            driver.Action.GetUrl().Expect.String.Equals(url.Name);
        }

        // Deluxe online 3/3
       // [TestCase(123)]

        [UITest, HRBlock.CTF.Scope("AEM")]
        public void DeluxeOnlineSelfEmployed (IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/deluxe-online-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.SelfEmployed);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            wait.UntilVisible(pom.EarnedIncomeContinueBtn);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);


            wait.UntilVisible(pom.ValidateButton);



            driver.Action.GetUrl().Expect.String.Equals(url.Name);
        }




        //TODO: Deluxe WithoutState
        [UITest, HRBlock.CTF.Scope("TaxSoftware")]
        public void DeluxeWithState(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<TaxSoftwarePOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/tax-software/deluxe-tax-software/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.Retired);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.YesItemizedDeductions);
            driver.Action.Click(pom.ItemizedDeductionsContinueBtn);
            driver.Action.Click(pom.YesFileStateTaxes);
            driver.Action.Click(pom.FileStateTaxesContinueBtn);

            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

       
        [UITest, HRBlock.CTF.Scope("AEM")]
        //[DependsOn(typeof(HelpMeChoose), nameof(DeluxeOnlineWithoutState))]

            //Premium online 1/2
        public void PremiumOnlineStudent (IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            url = new UrlString();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/premium-online-tax-filing/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.YesEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);
            
            wait.UntilVisible(pom.ValidateButton);
            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }

        [UITest, HRBlock.CTF.Scope("AEM")]
        public void PremiumOnlineFreelance(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            url = new UrlString();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/premium-online-tax-filing/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.ContractAndFreelance);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.YesEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);

            wait.UntilVisible(pom.ValidateButton);
            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }




        // Self-Employed 
        [UITest, HRBlock.CTF.Scope("AEM")]
        //[DependsOn(typeof(HelpMeChoose), nameof(PremiumOnline))]

        public void SelfEmployed(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            url = new UrlString();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/self-employed-online-tax-filing/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.SelfEmployed);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.YesBusinessExpense);
            driver.Action.Click(pom.ContinueBtn);


            wait.UntilVisible(pom.ValidateButton);
            driver.Action.GetUrl().Expect.String.Equals(url.Name);
        }
        //Basic Online Assist
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(FreeOnline))]
        public void FreeOnlineAssist(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/basic-online-assist-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.HelpFromPro);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);
            driver.Action.Click(pom.NoHSA);
            driver.Action.Click(pom.HSAContinueBtn);
            wait.UntilVisible(pom.ValidateButton);



            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }
        //Deluxe Online Assist
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(FreeOnlineAssist))]
        public void DeluxeOnlineAssist(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/deluxe-online-assist-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.HelpFromPro);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.ContractAndFreelance);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);


            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

        //PremiumOnline Assist
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(DeluxeOnlineAssist))]
        public void PremiumOnlineAssist(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();
            url.Name= "https://hrbcomlnp.hrblock.com/online-tax-filing/premium-online-assist-tax-filing/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.MeetInPerson);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.YesEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);

            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);



        }

        //Self-Employed Assist

        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(PremiumOnlineAssist))]
        public void SelfEmployedAssist(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();
             url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/self-employed-online-assist-tax-filing/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.HelpFromPro);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.SelfEmployed);
            driver.Action.Click(pom.EmploymentStatusContinueBtn);
            driver.Action.Click(pom.YesBusinessExpense);
            driver.Action.Click(pom.BusinessExpenseContinueBtn);

            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

        [UITest, HRBlock.CTF.Scope("TaxSoftware")]
        public void BasicSoftware(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<TaxSoftwarePOM>();
            driver.GoToUrl();
            url.Name = "https://hrbcomlnp.hrblock.com/tax-software/basic-tax-software/";

            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.Retired);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.NoItemizedDeductions);
            driver.Action.Click(pom.ItemizedDeductionsContinueBtn);
            driver.Action.Click(pom.NoFileStateTaxes);
            driver.Action.Click(pom.FileStateTaxesContinueBtn);


            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }


        //deluxe tax software 1/2

        [UITest, HRBlock.CTF.Scope("TaxSoftware")]
        public void DeluxeWithStateSoftwareYesDeductions(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<TaxSoftwarePOM>();
            driver.GoToUrl();
            url.Name = "https://hrbcomlnp.hrblock.com/tax-software/deluxe-tax-software/";

            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.Retired);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.YesItemizedDeductions);
            driver.Action.Click(pom.ItemizedDeductionsContinueBtn);
            driver.Action.Click(pom.YesFileStateTaxes);
            driver.Action.Click(pom.FileStateTaxesContinueBtn);


            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }

        //deluxe tax software 2/2
        [UITest, HRBlock.CTF.Scope("TaxSoftware")]
        public void DeluxeWithStateSoftwareNoDeductions(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<TaxSoftwarePOM>();
            driver.GoToUrl();
            url.Name = "https://hrbcomlnp.hrblock.com/tax-software/deluxe-tax-software/";

            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.Retired);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.NoItemizedDeductions);
            driver.Action.Click(pom.ItemizedDeductionsContinueBtn);
            driver.Action.Click(pom.YesFileStateTaxes);
            driver.Action.Click(pom.FileStateTaxesContinueBtn);


            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }

        //Premium tax software 

        [UITest, HRBlock.CTF.Scope("TaxSoftware")]
        public void PremiumTaxSoftware(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<TaxSoftwarePOM>();
            driver.GoToUrl();
            url.Name = "https://hrbcomlnp.hrblock.com/tax-software/premium-tax-software/";

            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.SelfEmployed);
            driver.Action.Click(pom.ContinueBtn);


            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }


        //Premium and business tax software 
        [UITest, HRBlock.CTF.Scope("TaxSoftware")]
        public void PremiumAndBusinessTaxSoftware(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<TaxSoftwarePOM>();
            driver.GoToUrl();
            url.Name = "https://hrbcomlnp.hrblock.com/tax-software/premium-small-business-tax-software/";

            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.OwnABusiness);
            driver.Action.Click(pom.ContinueBtn);


            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }



    }
}
