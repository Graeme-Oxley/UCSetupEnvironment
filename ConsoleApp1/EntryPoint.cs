﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("Yes I can see the element");
        }
        else
        {
            RedMessage("Yes I can see the element");
        }
        Thread.Sleep(3000);

        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
