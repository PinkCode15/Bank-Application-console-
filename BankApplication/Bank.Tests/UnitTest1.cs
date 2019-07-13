using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApplication;

namespace Bank.Tests
{
    /// <summary>
    /// The <c>Test1</c> class
    /// </summary>
    [TestClass]
    public class Test1
    {
        SavingsAccount zero = SavingsAccount.CreateAccount("Onuora Stacey", "1500", 4000);
        CurrentAccount one = CurrentAccount.CreateAccount("Dwayne Kelly", "1501", 1000);

        /// <summary>
        /// This tests for when a deposit is made to an account
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var actual = BankAccount.Deposit("232300051", "Chinelo", 5000);
            var expected = 9000.0;
            Assert.AreEqual(actual, expected);

        }
        

        }

     
    /// <summary>
    /// The <c>Test2</c> class
    /// </summary>
    [TestClass]
    public class Test2
    {
        /// <summary>
        /// This tests when a deposit is made to an account that does not exist
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            var actual = BankAccount.Deposit("232300251", "Stella", 5000);
            var expected = -2.0;
            Assert.AreEqual(actual, expected);

        }

       
    }

    /// <summary>
    /// The <c>Test3</c> class
    /// </summary>
    [TestClass]
    public class Test3
    {
        SavingsAccount two = SavingsAccount.CreateAccount("Hill Billy", "1502", 1000);

        /// <summary>
        /// This tests when a withdraw is made from an account with insufficient funds
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            var actual = two.Withdraw("1502",500);
            var expected = 0.0;
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test4</c> class
    /// </summary>
    [TestClass]
    public class Test4
    {
        CurrentAccount three = CurrentAccount.CreateAccount("Wendy White", "1503", 8000);

        /// <summary>
        /// This tests when a withdraw is made from an account
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            var actual = three.Withdraw("1503", 3000);
            var expected = 5000.0;
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test5</c> class
    /// </summary>
    [TestClass]
    public class Test5
    {
        SavingsAccount four = SavingsAccount.CreateAccount("Okorocha Johan", "1504", 1200);

        /// <summary>
        /// This tests when a withdraw is made from an account with an incorrect pin
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            var actual = four.Withdraw("1514", 200);
            var expected = -1.0;
            Assert.AreEqual(actual, expected);

        }


    }

    
    //[TestClass]
    //public class Test6
    //{
      //  CurrentAccount five = CurrentAccount.CreateAccount("Dennis Tom", "1505", 30000);

        //[TestMethod]
        //public void TestMethod6()
        //{
          //  var actual = five.Transfer("1505", "232300451", 10000);
          //  var expected = Tuple.Create(-3.0, -3.0); ;
           // Assert.AreEqual(actual, expected);

       // }


   // }


    /// <summary>
    /// The <c>Test6</c> class
    /// </summary>
    [TestClass]
    public class Test6
    {
        SavingsAccount five = SavingsAccount.CreateAccount("Qwaty Rita", "1505",3000);

        /// <summary>
        /// This tests when a transfer is made from one account to another
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            var actual = five.Transfer("1505", "232300251", 300);
            var expected = Tuple.Create(2700.0, 1300.0); ;
            Assert.AreEqual(actual, expected);

        }


    }


    /// <summary>
    /// The <c>Test7</c> class
    /// </summary>
    [TestClass]
    public class Test7
    {
        CurrentAccount six = CurrentAccount.CreateAccount("Nena Wellens", "1506", 8000);

        /// <summary>
        /// This tests when a transfer is made to an account with an incorrect pin
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            var actual = six.Transfer("1516", "232300551", 6000);
            var expected = Tuple.Create(-1.0, -1.0); ;
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test8</c> class
    /// </summary>
    [TestClass]
    public class Test8
    {
        SavingsAccount seven = SavingsAccount.CreateAccount("Frosh Timi", "1507", 500);

        /// <summary>
        /// This tests when a transfer is made to an account that does not exist
        /// </summary>
        [TestMethod]
        public void TestMethod8()
        {
            var actual = seven.Transfer("1507", "232301551", 6000);
            var expected = Tuple.Create(-2.0, -2.0); ;
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test9</c> class
    /// </summary>
    [TestClass]
    public class Test9
    {
        SavingsAccount eight = SavingsAccount.CreateAccount("Romola Adefarati", "1508", 1200);

        /// <summary>
        /// This tests when a transfer is made with insufficient funds
        /// </summary>
        [TestMethod]
        public void TestMethod9()
        {
            var actual = eight.Transfer("1508", "232300051", 1000);
            var expected = Tuple.Create(-0.0, -0.0); 
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test10</c> class
    /// </summary>
    [TestClass]
    public class Test10
    {
        CurrentAccount nine = CurrentAccount.CreateAccount("Hems William", "1509", 25000);

        /// <summary>
        /// This tests when account balance is accessed with incorrect pin
        /// </summary>
        [TestMethod]
        public void TestMethod10()
        {
            var actual = nine.GetBalance("1520");
            var expected = -1.0; 
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test11</c> class
    /// </summary>
    [TestClass]
    public class Test11
    {
        CurrentAccount ten = CurrentAccount.CreateAccount("Realz Ifunanya", "1510",500);

        /// <summary>
        /// This tests when account blance is gotten
        /// </summary>
        [TestMethod]
        public void TestMethod11()
        {
            BankAccount.Deposit("232301051", "Stefanie", 4000);
            ten.Transfer("1510", "232301051", 800);
            var actual = ten.GetBalance("1510");
            var expected = 4500.0; 
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test12</c> class
    /// </summary> 
    [TestClass]
    public class Test12
    {
        CurrentAccount eleven = CurrentAccount.CreateAccount("Aliya Nicole", "1511", 300000);

        /// <summary>
        /// This tests the interest rate of current acccount with a withdraw operation
        /// </summary>
        [TestMethod]
        public void TestMethod12()
        {
            var actual = eleven.Withdraw("1511", 180000);
            var expected = 119640.0; 
            Assert.AreEqual(actual, expected);

        }


    }


    /// <summary>
    /// The <c>Test13</c> class
    /// </summary>
    [TestClass]
    public class Test13
    {
        SavingsAccount twelve = SavingsAccount.CreateAccount("Dino Dubem", "1512", 170000);

        /// <summary>
        /// This tests the interest rate of savings account with a withdraw operation
        /// </summary>
        [TestMethod]
        public void TestMethod13()
        {
            var actual = twelve.Withdraw("1512", 150000);
            var expected = 19850.0; 
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test14</c> class
    /// </summary>
    [TestClass]
    public class Test14
    {
        SavingsAccount thirteen = SavingsAccount.CreateAccount("Lena Ally", "1513", 2000);

        /// <summary>
        /// This tests the interest rate of savings account with transfer operation
        /// </summary>
        [TestMethod]
        public void TestMethod14()
        {
            BankAccount.Deposit("232301351", "Pauline", 200000);
            var actual = thirteen.Transfer("1513", "232300951", 153000);
            var expected = Tuple.Create(48847.0, 178153.0);
            Assert.AreEqual(actual, expected);

        }


    }

    /// <summary>
    /// The <c>Test15</c> class
    /// </summary>
    [TestClass]
    public class Test15
    {
        CurrentAccount fourteen = CurrentAccount.CreateAccount("Nui Dan", "1514", 500000);

        /// <summary>
        /// This tests the interest rate of current account with transfer operation
        /// </summary>
        [TestMethod]
        public void TestMethod15()
        {
            var actual = fourteen.Transfer("1514", "232300351", 300000);
            var expected = Tuple.Create(199400.0, 305600.0);
            Assert.AreEqual(actual, expected);

        }


    }




}
