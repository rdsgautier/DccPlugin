
#define WIN32_LEAN_AND_MEAN
#include "windows.h"

#ifdef _DEBUG
#define _DEBUG_IS_ENABLED
#undef _DEBUG
#endif
#include <Python.h>
#if defined(_DEBUG_IS_ENABLED)
#define _DEBUG
#endif

#ifdef DLL_EXPORTS
#define DLL_API __declspec(dllexport)
#else
#define DLL_API __declspec(dllimport)
#endif
