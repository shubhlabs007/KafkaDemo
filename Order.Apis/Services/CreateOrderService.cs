using Confluent.Kafka;
using Microsoft.Extensions.Options;
using Order.Apis.Interface;
using Order.Apis.Models;
using Order.Apis.Constants;

namespace Order.Apis.Services
{
    public class CreateOrderService : ICreateOrder
    {
        private readonly ProducerConfig _producerConfig;

        public CreateOrderService(IOptions<ProducerConfig> producerConfig)
        {
            _producerConfig = producerConfig.Value;
        }

        public string CreateOrder(Orders order)
        {
            string status = string.Empty;
            using (var producerBuilder = new ProducerBuilder<long, string>(_producerConfig)
                    .SetValueSerializer(Serializers.Utf8)
                    .Build())
            {

                var record = new Message<long, string>()
                {
                    Key = 1,
                    Value = order.ToString()
                };
                
                var deliveryResult = producerBuilder.ProduceAsync(Constants.Constants.KAFKA_TOPIC, record).Result;
                if (deliveryResult.Status.Equals(0))
                {
                    Console.WriteLine($"Message Produced to kafka topic {Constants.Constants.KAFKA_TOPIC}");
                    
                }
                status = deliveryResult.Status.ToString();
            }
            return status;
            
        }
    }
}
