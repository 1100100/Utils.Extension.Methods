﻿using System.Text;

namespace Utils.Extension.Methods
{
	public static class ByteExtension
	{
		public static string AsString(this byte[] bytes)
		{
			if (bytes == null || bytes.Length == 0)
				return string.Empty;
			return Encoding.UTF8.GetString(bytes);
		}
	}
}
