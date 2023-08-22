using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator: AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator() {

            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Lütfen ürün adı giriniz.").MaximumLength(150).MinimumLength(3).WithMessage("Ürün ismini 3 ile 150 karakter arası giriniz.");

            RuleFor(p => p.Stock).NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz.").Must(s => s >= 0).WithMessage("Stok bilgisi negatif olamaz.");

            RuleFor(p => p.Price).NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz.").Must(s => s >= 0).WithMessage("Stok bilgisi negatif olamaz.");

        }
        



    }
}
