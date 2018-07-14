using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using RoutingProject.Attributes.Validation;

namespace RoutingProject.Models.ViewModels {
	public class UserView {
		public int Id { get; set; }
		[Required(ErrorMessage = "Введите email")]
		[ValidEmail(ErrorMessage = "Невалидный email")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Введите пароль")]
		public string Password { get; set; }
		[System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Пароли должны совпадать")]
		public string ConfirmPassword { get; set; }
		public string Captcha { get; set; }
		public string AvatarPath { get; set; }

		public int BirthdateDay { get; set; }
		public int BirthdateMonth { get; set; }
		public int BirthdateYear { get; set; }

		public DateTime Birthdate {
			get { return new DateTime(BirthdateYear, BirthdateMonth, BirthdateDay); }
			set {
				BirthdateDay = value.Day;
				BirthdateMonth = value.Month;
				BirthdateYear = value.Year;
			}
		}

		public IEnumerable<SelectListItem> BirthdateDaySelectList {
			get {
				return GetSelectRange(1, 32, BirthdateDay, day => day.ToString());
			}
		}

		public IEnumerable<SelectListItem> BirthdateMonthSelectList {
			get {
				return GetSelectRange(1, 13, BirthdateMonth, month => new DateTime(2000, month, 1).ToString("MMMM"));
			}
		}

		public IEnumerable<SelectListItem> BirthdateYearSelectList {
			get {
				return GetSelectRange(1910, DateTime.Now.Year, BirthdateYear, year => year.ToString());
			}
		}

		private IEnumerable<SelectListItem> GetSelectRange(int from, int to, int selector, Func<int, string> format) {
			for (int i = from; i < to; i++) {
				yield return new SelectListItem {
					Value = i.ToString(),
					Text = format(i),
					Selected = i == selector
				};
			}
		}
	}
}