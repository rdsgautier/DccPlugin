#include "stdafx.h"
#include "BaseWrapper.h"

#include "CLRWrapper.h"

using namespace BaseWrapper;
void Functions::UpdateUI()
{
	CLRWrapper::Instance->UpdateUI();
}
