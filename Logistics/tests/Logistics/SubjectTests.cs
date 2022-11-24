//using Xunit;
using System;
using Logistics.Domain.Subjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class SubjectTests
{
    [TestMethod]
    public void CreateSubject()
    {
        Subject subject = new Subject("LAPR1", "Laboratory Project 1", "A subject to create random projects");
        Assert.IsNotNull(subject);
    }
}
