namespace BlazorEcommerce.Server.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
    }
}
