//TODO: Reimplement with AutoMapper API
// using AutoMapper;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Profile;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping
// {
//     public class KrakenMapper
//     {
//         public static IMapper Mapper { get; }
        
//         static KrakenMapper()
//         {
//             var config = new MapperConfiguration(cfg => {
//                 cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
//                 cfg.AddProfile<DefaultProfile>();
//             });

//             config.AssertConfigurationIsValid();

//             Mapper = config.CreateMapper();
//         }
//     }
// }
