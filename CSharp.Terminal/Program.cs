﻿using CSharp.Core.Chapters;
using CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility;
using CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility.RealWolrd;
using CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.AbstractExample;
using CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.RealWorld;
using CSharp.Core.Chapters.DesignsPattern.Behavioural.Interpreter;
using CSharp.Core.Chapters.DI;
using CSharp.Core.Chapters.EntityFramework;
using CSharp.Core.Chapters.GC;
using CSharp.Core.Chapters.OOP;
using CSharp.Core.Chapters.OOP.Inheritance;
using CSharp.Core.Chapters.OOP.Static;
using CSharp.Core.Chapters.OOP.Static.Constructors;
using CSharp.Core.Combinations;
using CSharp.Core.Exams;
using CSharp.Core.Exams.ServiceTitans;
using CSharp.Core.Exams.YNAB;
using CSharp.Terminal.DI;
using inheritance3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Terminal
{
    class Program
    {

        static void Main(string[] args)
        {
            //EntryPoint start = new EntryPoint();
            //start.Execute();

            //TextInput input = new NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');

            //Console.WriteLine(input.GetValue());

            //DriverExam.ExecuteExercise(new Exercise());

            //int[] numbers = new int []{2,12,12 };

            //List<int> uniqueValues = numbers.ToList().Distinct().ToList();

            //var resul= uniqueValues.Sum();

            //DIResolver dir = new DIResolver();
            //dir.Resolve();
            //dir.ResolveByConfig();

            //AdvanceProgram ap = new AdvanceProgram();
            //ap.Calculate();

            //CORStartup.Call();
            //COR_RW.Call();

            //CommandStartup.Call();

            //CommandREStartup.Call();

            //InterpreterStartup.Call();

            //YNAB ynab = new YNAB();
            //ynab.Start();

            //Anagram.Start();
            //FirstElementProblem.GetAllNumbersWithOneOccurances();
            //FirstElementProblem.GetFirstNumbersWithOneOccurances();

            BitProblems bitProblems = new BitProblems();
            //bitProblems.ConvertToBit();
            //bitProblems.ConvertToBytes();
            //bitProblems.CalculateXOR();
            //DiagonalDifference diff = new DiagonalDifference();
            //diff.Fraction();
            //diff.Difference();
            //FindOneOccurance fo = new FindOneOccurance();
            //fo.Get();

            AmazonInterviewQuestion interview = new AmazonInterviewQuestion();
            //interview.MaxNumberOf0sByFlippingSubarray();
            //interview.FistCircularTour();

            //CacheRepository cache = new CacheRepository();
            //UserService userService = (UserService)cache.Get(ServiceNames.UserService);

            //Thread.Sleep(2000);
            //ServiceBase baseervice = cache.Get(ServiceNames.UserService);

            //Thread.Sleep(7000);
            // userService = (UserService)cache.Get(ServiceNames.UserService);

            ServiceTitans titans = new ServiceTitans();
            //titans.Start();

            //OOPTests oopTest = new OOPTests();
            //OOPTests.Test();
            //InTester.Test();
            //CarTesters.Test();
            //InTester3.Test();

            //StaticConTests.Test();
            //StaticClassTests.Test();
            //TestDisposePattern.Test();

            //new PlaneSeat().solution(2, "1A 2F 1C");
            //new PlaneSeat().solution(1, "");

            int[] A = new int[] { 5, 4, 3, 2, 6 };

            new ToptalPlaneSeat().solution(A);


            Console.ReadLine();
        }
    }
}
