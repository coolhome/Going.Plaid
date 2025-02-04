namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the transaction.</para>
/// </summary>
public enum WalletTransactionStatus
{
	/// <summary>
	/// <para>This is the initial state of all transactions. It indicates that the transaction has been initiated and is currently being processed.</para>
	/// </summary>
	[EnumMember(Value = "INITIATED")]
	Initiated,

	/// <summary>
	/// <para>The transaction has been successfully executed.</para>
	/// </summary>
	[EnumMember(Value = "EXECUTED")]
	Executed,

	/// <summary>
	/// <para>The transaction has been blocked for violating compliance rules. This is a terminal status.</para>
	/// </summary>
	[EnumMember(Value = "BLOCKED")]
	Blocked,

	/// <summary>
	/// <para>The transaction failed to process successfully. This is a terminal status.</para>
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}