using System;
using System.Threading.Tasks;

namespace ianexamapp
{
	public interface IFileHelper
	{
		Task<string> LoadLocalFileAsync(string filename);
		Task<bool> SaveLocalFileAsync(string filename, string data);
		string GetNameWithPath(string filename);
	}
}

