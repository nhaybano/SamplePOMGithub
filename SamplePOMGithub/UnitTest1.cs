namespace SamplePOMGithub.PageObjects
{
    public class Tests:BasePage
    {
        GitLogin git;
       
        [SetUp]
        public void Setup()
        {
            intialize();
            git = new GitLogin(driver);
           
        }

        [Test]
        public void Test1()
        {
            string returnedtxt = driver.Title;
            Assert.That(returnedtxt, Is.EqualTo("Its is Really"));
        }
    }
}