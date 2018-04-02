#include "stdafx.h"

#include <boost/python.hpp>
using namespace boost::python;

#include "WrapperDccPlugin/BaseWrapper.h"
using namespace BaseWrapper;

struct World
{
	void set(std::string msg) { this->msg = msg; }
	std::string greet() const{ return msg;}
	void UpdateUI(){ Functions::UpdateUI(); }

	std::string msg;
};

BOOST_PYTHON_MODULE(plugin)
{
	class_<World>("World")
		.def("greet", &World::greet)
		.def("set", &World::set)
		.def("updateUI", &World::UpdateUI)
		;
}