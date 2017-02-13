using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
	public class PasswordVerifier
	{
		public bool Verify(string password)
		{
			return StringUtils.Trim(password) == "SUPER SECRET";
		}
	}
}
