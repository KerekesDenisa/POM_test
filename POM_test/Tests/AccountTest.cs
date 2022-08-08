﻿using POM_test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test.Tests
{
    public class AccountTest : BaseTest
    {
        [Test]
        public void AccountPageTest()
        {

            PagesStore.AccountPage.ClickAccount();

            PagesStore.AccountPage.ClickOnAccountLinks("My Cart");

        }

    }
}