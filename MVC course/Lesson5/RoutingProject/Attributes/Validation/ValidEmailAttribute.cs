using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace RoutingProject.Attributes.Validation {
	[AttributeUsage(AttributeTargets.Property)]

	public class ValidEmailAttribute : ValidationAttribute {
		public override bool IsValid(object value) {
			var source = value as string;
			if (string.IsNullOrWhiteSpace(source)) {
				return true;
			}

			return IsValidEmail(source);
		}

		bool IsValidEmail(string email) {
			try {
				return new MailAddress(email).Address == email;
			}
			catch {
				return false;
			}
		}
	}
}