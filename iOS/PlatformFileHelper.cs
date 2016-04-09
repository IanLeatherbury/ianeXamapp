using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Xamarin.Forms;
using eXam;
using ianexamapp;

namespace eXam
{
	public class PlatformFileHelper : IFileHelper
	{
		public Task<string> LoadLocalFileAsync (string filename)
		{
			try
			{
				return Task.FromResult(File.ReadAllText(GetNameWithPath(filename)));
			}
			catch 
			{
				return Task.FromResult<string>(null);
			}
		}

		public Task<bool> SaveLocalFileAsync (string filename, string data)
		{
			File.WriteAllText (GetNameWithPath(filename), data);

			return Task.FromResult (true);
		}

		public string GetNameWithPath (string filename)
		{
			return "";
		}
	}
}