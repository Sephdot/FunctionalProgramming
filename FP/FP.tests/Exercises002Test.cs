using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Tests
{
    public class Exercises002Test
    {
        [Test]
        public void GetEmailList_ShouldReturnCorrectEmails()
        {
            List<string> emailList = Exercises002.GetCoolPeople();

            emailList.Should().BeEquivalentTo(new List<string>
            {
                "rich.neat@boardgamer.com",
                "poppy.mcdonnell@irishdancer.com",
                "neil.hughes@walkingoncustard.com",
                "alice.yang@midfielder.com",
                "pippa.austin@musician.com"
            });
        }


        // tests to make:
        // get username
        [Test]
        public void GetUsernameTest()

            // edit to test console output
        {
            // Arrange
            string input = "rich.neat@boardgamer.com";
            string result = "rich.neat";
            new StringWriter().Write(input);

            // The Action we're testing - in this case, it's the default Add method
            Action<string> GetUsername = Exercises002.GetUsername;

            // Act
            GetUsername(input);

            // Assert
            Console.Out.Should().Be(result);
        }


        // printcoolpeople
        // squarednums
        // filteremails
        /*[Test]
        [TestCase(new List<string>() {"asfbashfbhas@", "$£^^%&.com", "ascbhfs@northcoders.com", "safas@aol.com"}, ".com", new List<string>() {"ascbhfs@northcoders.com", "safas@aol.com"})]
        [TestCase(new List<string>({"asfbashfbhas@", "$£^^%&.com", "ascbhfs@northcoders.com", "safas@aol.com", "sabas@.co.uksab", "csabcasb{]}{}}@Couk", "abcsabcb@co.uk", "abcsabcb@.co.uk", "assba@schac.co.uk"}), ".co.uk", { "assba@schac.co.uk"}
        TestName = ".co.uk" )]
        public void TestFilterEmails(List<string> input, string key, List<string> output)
        {
            dict = FilterEmails(input)


        dict[key].Should.Be(output)
        }*/
    }
}
