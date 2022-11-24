using System;
using Logistics.Domain.Shared;
using Logistics.Domain.Subjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SubjectDescriptionTests
{

    [TestMethod]
    public void CreateDescription()
    {
        SubjectDescription description = new SubjectDescription("Description");
        Assert.IsNotNull(description);
    }

    [TestMethod]
    public void NullDescription(){
        try{
            new SubjectDescription(null);
            Assert.Fail("An exception should have been thrown.");
        }catch(BusinessRuleValidationException ex){
            string expected = "ERROR: Description cannot be null.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void LongDescription()
    {
        try
        {
            new SubjectDescription("0123456789, 0123456789, 0123456789, 0123456789, 0123456789, 01");
            Assert.Fail("An exception should have been thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Description is too long.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

}