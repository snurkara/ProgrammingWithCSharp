﻿using RobotFactory.Factories;
using RobotFactory.Models;

namespace RobotFactory.Reports;

public class ReportGenerator
    :IReportGenerator
{
    public void Generate(List<Robot> robots)
    {
        Console.WriteLine("********************");
        Console.WriteLine("*  Factory Report  *");
        Console.WriteLine("********************");

        foreach (var robot in robots)
        {
            Console.WriteLine(robot);
        }
    }
}
