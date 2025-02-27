﻿// <copyright file="LinqPlaceOrderPage.Map.cs" company="Automate The Planet Ltd.">
// Copyright 2022 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

using OpenQA.Selenium;

namespace AdvancedSpecificationDesignPattern.Pages.LinqPlaceOrderPage;

public partial class LinqPlaceOrderPage
{
    public IWebElement TotalPrice
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[7]/td[2]/strong"));
        }
    }

    public IWebElement EstimatedTaxPrice
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[5]/td[2]"));
        }
    }

    public IWebElement ItemsPrice
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[1]/td[2]"));
        }
    }

    public IWebElement TotalBeforeTaxPrice
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[4]/td[2]"));
        }
    }

    public IWebElement GiftWrapPrice
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[2]/td[2]"));
        }
    }

    public IWebElement ShippingTax
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[2]/td[2]"));
        }
    }

    public IWebElement CreditCard
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='creditCard']/table/tbody/tr[2]/td[2]"));
        }
    }

    public IWebElement SecurityNumber
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id='securityNumber']/table/tbody/tr[2]/td[2]"));
        }
    }

    public IWebElement CreditCardOwner
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id=creditCardOwner']/table/tbody/tr[2]/td[2]"));
        }
    }

    public IWebElement Wiretransfer
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id=wiretransfer']/table/tbody/tr[2]/td[2]"));
        }
    }

    public IWebElement PromotionalCode
    {
        get
        {
            return Driver.FindElement(By.XPath("//*[@id=promotionalCode']/table/tbody/tr[2]/td[2]"));
        }
    }
}