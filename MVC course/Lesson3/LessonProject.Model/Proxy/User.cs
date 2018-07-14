using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LessonProject.Model {
	public partial class User {
		public string ConfirmPassword { get; set; }
		public string Captcha { get; set; }

		public static string GetActivateUrl() {
			return Guid.NewGuid().ToString("N");
		}
	}
}