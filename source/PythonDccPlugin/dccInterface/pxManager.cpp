#include "stdafx.h"

#include <boost/python.hpp>
using namespace boost::python;

#include "WrapperDccPlugin/BaseWrapper.h"
using namespace BaseWrapper;

struct UITest
{
	void set(std::string msg) { this->msg = msg; }
	std::string greet() const{ return msg;}
	void UpdateUI(){ Functions::UpdateUI(); }

	std::string msg;
};

BOOST_PYTHON_MODULE(cppplugin)
{
	class_<UITest>("UITest")
		.def("greet", &UITest::greet)
		.def("set", &UITest::set)
		.def("updateUI", &UITest::UpdateUI)
		;
}