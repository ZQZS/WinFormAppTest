using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Common;

class Helper
{
    public static string addJuhao(string str)
    {
        return str + ".";
    }
}
static class Helper2
{
    public static string addJuhao(this string str)
    {
        return str + ".";
    }
    public static void Born(this Person person)
    {
        MessageBox.Show($"{person.Name}出生了");
    }
    public static void AddId(this Person person,int id)
    {
        person.Id = id;
        MessageBox.Show($"身份证{person.Id}");
    }
    public static void ShowPerson(this IHelper helper)
    {
        MessageBox.Show("I am humant");
    }
    public static void JoinPerson(this IHelper helper)
    {
        MessageBox.Show("I am humant2");
    }
}

