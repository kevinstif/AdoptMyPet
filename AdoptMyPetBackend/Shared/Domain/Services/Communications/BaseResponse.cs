namespace AdoptMyPetBackend.Shared.Domain.Services.Communications
{
    public abstract class BaseResponse<T>
    {
        public string Message {  get; private set; }
        public bool Success { get; private set; }
        public T Resource { get; private set; }

        protected BaseResponse(string message)
        {
            Message = message;
            Success = false;
            Resource = default;
        }

        protected BaseResponse(T resource)
        {
            Message = string.Empty;
            Success = true;
            Resource = resource;
        }
    }
}
