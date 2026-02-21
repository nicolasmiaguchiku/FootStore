using FootStore.CroosCutting.Models;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace FootStore.CroosCutting.Extensions
{
    public static class MongoExtentions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services, MongoSettings mongoSettings)
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));

            var convertionPack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register("EnumStringConvention", convertionPack, t => true);

            var mongoClient = new MongoClient(mongoSettings.ConnectionString);
            var client = mongoClient.GetDatabase(mongoSettings.Database);

            services.AddSingleton<IMongoClient>(_ => mongoClient);

            services.AddSingleton(sp =>
            {
                var mongoClient = sp.GetService<IMongoClient>()!;
                var database = mongoClient.GetDatabase(mongoSettings.Database);

                return database;
            });

            return services;
        }
    }
}