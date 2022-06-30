using System;

public static class LogAnalysis
{
	// TODO: define the 'SubstringAfter()' extension method on the `string` type
	public static string SubstringAfter(this string str, string Delimiter)
	{
		int index = str.IndexOf(Delimiter[0]) + Delimiter.Length;
		return str.Substring(index);
	}

	// TODO: define the 'SubstringBetween()' extension method on the `string` type
	public static string SubstringBetween(this string str, string Del1, string Del2)
	{
		int indexOfDelimiter1 = str.IndexOf(Del1[0]) + Del1.Length;
		int indexOfDelimiter2 = str.IndexOf(Del2);

		return str.Substring(indexOfDelimiter1, indexOfDelimiter2 - indexOfDelimiter1);
	}

	// TODO: define the 'Message()' extension method on the `string` type
	public static string Message(this string str)
	{
		return str.SubstringAfter(":").Trim();
	}

	// TODO: define the 'LogLevel()' extension method on the `string` type
	public static string LogLevel(this string str)
	{
		return str.SubstringBetween("[", "]");
	}
}
