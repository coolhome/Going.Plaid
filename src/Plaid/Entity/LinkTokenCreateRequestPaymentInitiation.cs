namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Payment Initiation (Europe) product. This field is required if <c>payment_initiation</c> is included in the <c>products</c> array.</para>
/// </summary>
public class LinkTokenCreateRequestPaymentInitiation
{
	/// <summary>
	/// <para>The <c>payment_id</c> provided by the <c>/payment_initiation/payment/create</c> endpoint.</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; set; } = default!;
}