using Grpc.Core;
using gRPCService;

namespace gRPCService.Services
{
    
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        public override Task<CustomReply> CustomFunc(CustomRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CustomReply
            {
                Message = "What's poppin  " + request.Name
            });
        }
        public override Task<TeachersReply> GetTeachers(TeacherRequest request, ServerCallContext context)
        {
            return Task.FromResult(new TeachersReply
            {
                
            });
        }
    }
}