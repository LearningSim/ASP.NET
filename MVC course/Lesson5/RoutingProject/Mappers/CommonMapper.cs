using System;
using AutoMapper;
using LessonProject.Model;
using RoutingProject.Models.ViewModels;

namespace RoutingProject.Mappers {
	public class CommonMapper : IMapper {
		static CommonMapper() {
			Mapper.Initialize(cfg => {
				cfg.CreateMap<User, UserView>();
				cfg.CreateMap<UserView, User>();
			});
		}

		public TDestination Map<TSource, TDestination>(TSource source){
			return Mapper.Map<TSource, TDestination>(source);
		}
	}
}