namespace API
{
    public static class AutomapperConfig
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Game, Models.GameDto>()
                    .ForMember(dest => dest.Rating, options => options.MapFrom(src => $"{src.Rating}/10"));
            });
        }
    }
}
