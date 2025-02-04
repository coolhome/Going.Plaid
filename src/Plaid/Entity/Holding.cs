namespace Going.Plaid.Entity;

/// <summary>
/// <para>A securities holding at an institution.</para>
/// </summary>
public record Holding
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c> associated with the holding.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid <c>security_id</c> associated with the holding.</para>
	/// </summary>
	[JsonPropertyName("security_id")]
	public string SecurityId { get; init; } = default!;

	/// <summary>
	/// <para>The last price given by the institution for this security.</para>
	/// </summary>
	[JsonPropertyName("institution_price")]
	public decimal InstitutionPrice { get; init; } = default!;

	/// <summary>
	/// <para>The date at which <c>institution_price</c> was current.</para>
	/// </summary>
	[JsonPropertyName("institution_price_as_of")]
	public DateOnly? InstitutionPriceAsOf { get; init; } = default!;

	/// <summary>
	/// <para>The value of the holding, as reported by the institution.</para>
	/// </summary>
	[JsonPropertyName("institution_value")]
	public decimal InstitutionValue { get; init; } = default!;

	/// <summary>
	/// <para>The cost basis of the holding.</para>
	/// </summary>
	[JsonPropertyName("cost_basis")]
	public decimal? CostBasis { get; init; } = default!;

	/// <summary>
	/// <para>The total quantity of the asset held, as reported by the financial institution. If the security is an option, <c>quantity</c> will reflect the total number of options (typically the number of contracts multiplied by 100), not the number of contracts.</para>
	/// </summary>
	[JsonPropertyName("quantity")]
	public decimal Quantity { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the holding. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the holding. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;
}