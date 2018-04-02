#pragma once

public ref class CLRWrapper
{
#pragma region Singleton
	CLRWrapper() {}
	CLRWrapper(const CLRWrapper%)
	{
		throw gcnew System::InvalidOperationException("CLRWrapper cannot be copy-constructed");
	}
	static CLRWrapper^ m_instance = gcnew CLRWrapper;

public:
	static property CLRWrapper^ Instance
	{
		CLRWrapper^ get(){ return m_instance; }
	}
#pragma endregion

public:
	void UpdateUI();

};
