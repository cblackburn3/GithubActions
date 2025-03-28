namespace GithubActionsLab;

[TestClass]
public class Addition
{
    [TestMethod]
    public void Add_Valid_Blackburn()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Blackburn()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Blackburn()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }

    [TestMethod]
    public void Subtract_Valid_Blackburn()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(3, Program.Subtract("5", "2"));
        Assert.AreEqual(0, Program.Subtract("7", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Blackburn()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Blackburn()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }

    [TestMethod]
    public void Multiply_Valid_Blackburn()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(10, Program.Multiply("5", "2"));
        Assert.AreEqual(35, Program.Multiply("7", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Blackburn()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Multiply_Null_Blackburn()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }

    [TestMethod]
    public void Divide_Valid_Blackburn()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(2, Program.Divide("10", "5"));
        Assert.AreEqual(7, Program.Divide("35", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Blackburn()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Divide_Null_Blackburn()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}
