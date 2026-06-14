using SupplierDueDiligence.API.Domain.Enums;

namespace SupplierDueDiligence.API.Config.Exceptions;

public class ScraperUnavailableException()
    : AppException(
        ErrorType.SERVICE_UNAVAILABLE,
        "Risk screening service is currently unavailable.",
        503,
        "The screening service failed due to high memory usage or resource limitations. Please try again later or contact support."
    )
{
}