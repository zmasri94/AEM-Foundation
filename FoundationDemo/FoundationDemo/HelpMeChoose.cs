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
        //[DependsOn(typeof(HelpMeChoose), nameof(SelfEmployedAssist))]
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
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.IWantToSendInDocs);
            driver.Action.Click(pom.ContinueBtn);

            wait.UntilVisible(pom.ValidateButton);
            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

        //drop off
        [UITest, HRBlock.CTF.Scope("AEM")]
        //[DependsOn(typeof(HelpMeChoose), nameof(FileWithTaxProVirtually))]
        public void FileWithTaxProDropOff(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)

        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            url.Name = "https://hrbcomlnp.hrblock.com/tax-offices/drop-off/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.ProDoesAll);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.MeetVirtually);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.BringToLocalOffice);
            driver.Action.Click(pom.ContinueBtn);

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
            driver.Action.Click(pom.ContinueBtn);
            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

   
        }
        //Free Online Package
        [UITest, HRBlock.CTF.Scope("AEM")]
       // [DependsOn(typeof(HelpMeChoose), nameof(MeetInOffice))]
        public void BasicOnline(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/free-online-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.HelpContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.EarnedIncomeContinueBtn);
            driver.Action.Click(pom.NoHSA);
            driver.Action.Click(pom.ContinueBtn);

            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }
      
        //Deluxe Online
        [UITest, HRBlock.CTF.Scope("AEM")]
        //[DependsOn(typeof(HelpMeChoose), nameof(BasicOnline))]
        public void DeluxeOnline(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/deluxe-online-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.ContractAndFreelance);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.ContinueBtn);


            wait.UntilVisible(pom.ValidateButton);



            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }

        //TODO: Premium Online
        // [DependsOn(typeof(HelpMeChoose), nameof(DeluxeOnline))]

        [UITest, HRBlock.CTF.Scope("AEM")]
       public void PremiumOnline (IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            driver.GoToUrl();

            url = new UrlString();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/premium-online-tax-filing/";
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.DoOwnTaxes);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.ContractAndFreelance);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.EarnedIncome);
            driver.Action.Click(pom.ContinueBtn);
            
            wait.UntilVisible(pom.ValidateButton);
            driver.Action.GetUrl().Expect.String.Equals(url.Name);


        }

        // Self-Employed 
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(DeluxeOnline))]

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
        [DependsOn(typeof(HelpMeChoose), nameof(SelfEmployed))]
        public void BasicOnlineAssist(IWebDriver driver, HRBlock.CTF.UI.Web.IWait wait, UrlString url)
        {
            var pom = driver.Pom<HelpMeChooseToolPOM>();
            url.Name = "https://hrbcomlnp.hrblock.com/online-tax-filing/basic-online-assist-tax-filing/";
            driver.GoToUrl();
            driver.Action.Click(pom.HelpMeChoose);
            driver.Action.Click(pom.HelpFromPro);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.Student);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.NoHSA);
            driver.Action.Click(pom.ContinueBtn);
            wait.UntilVisible(pom.ValidateButton);



            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }
        //Deluxe Online Assist
        [UITest, HRBlock.CTF.Scope("AEM")]
        [DependsOn(typeof(HelpMeChoose), nameof(BasicOnlineAssist))]
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
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.NoEarnedIncome);
            driver.Action.Click(pom.ContinueBtn);


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
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.EarnedIncome);
            driver.Action.Click(pom.ContinueBtn);

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
            driver.Action.Click(pom.ContinueBtn);
            driver.Action.Click(pom.YesBusinessExpense);
            driver.Action.Click(pom.ContinueBtn);

            wait.UntilVisible(pom.ValidateButton);

            driver.Action.GetUrl().Expect.String.Equals(url.Name);

        }



        }
    }
