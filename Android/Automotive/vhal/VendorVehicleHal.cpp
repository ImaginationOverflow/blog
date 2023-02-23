#define LOG_TAG "VendorVehicleHal_v2_0"

#include <android-base/logging.h>
#include <android/log.h>
#include <android-base/macros.h>

#include "VendorVehicleHal.h"
namespace android {
namespace hardware {
namespace automotive {
namespace vehicle {
namespace V2_0 {

namespace impl {

constexpr int INFO_EV_BATTERY_CAPACITY= (int)VehicleProperty::INFO_EV_BATTERY_CAPACITY;

VendorVehicleHal::VendorVehicleHal(VehiclePropertyStore* propStore, VehicleHalClient* client,
                                       EmulatedUserHal* emulatedUserHal)
    : EmulatedVehicleHal(propStore, client, emulatedUserHal),
	mRecurrentTimer(std::bind(&VendorVehicleHal::onTimer, this))
{
	std::chrono::milliseconds milis{100};
	std::chrono::nanoseconds nanos = std::chrono::duration_cast<std::chrono::nanoseconds>(milis);
	mRecurrentTimer.registerRecurrentEvent(nanos,0);
}

static int _vendorWriteProp = -1;

VehicleHal::VehiclePropValuePtr VendorVehicleHal::get(
        const VehiclePropValue& requestedPropValue, StatusCode* outStatus) {
    
 
	VehiclePropValuePtr v = nullptr;

	ALOGI("VendorVehicleHal::get  propId: 0x%x", requestedPropValue.prop);
	switch(requestedPropValue.prop)
	{
		case VENDOR_WRITE_PROP:{

			auto propValue = new VehiclePropValue();
			propValue->prop = VENDOR_WRITE_PROP;
			propValue->timestamp = elapsedRealtimeNano();
			propValue->value.int32Values.resize(1);
			propValue->value.int32Values[0] = _vendorWriteProp;

			v = getValuePool()->obtain(*propValue);

			ALOGI("VENDOR_WRITE_PROP calling ECU: to get its val to %d", _vendorWriteProp);
			return v;
		}
		case INFO_EV_BATTERY_CAPACITY:{
			auto propValue = new VehiclePropValue();
			propValue->prop = INFO_EV_BATTERY_CAPACITY;
			propValue->timestamp = elapsedRealtimeNano();
			propValue->value.floatValues.resize(1);
			propValue->value.floatValues[0] = 12000;

			v = getValuePool()->obtain(*propValue);

			ALOGI("INFO_EV_BATTERY_CAPACITY calling ECU: to get its val to %f", propValue->value.floatValues[0]);
			return v;
		}
  
	}
   
	return EmulatedVehicleHal::get(requestedPropValue, outStatus);
}

StatusCode VendorVehicleHal::set(const VehiclePropValue& propValue) {
 
	ALOGI("VendorVehicleHal::set  propId: 0x%x", propValue.prop);

	switch(propValue.prop)
	{
		//
		// Do not return in order to keep prop store updated 
		//
		case VENDOR_WRITE_PROP:
			ALOGI("VENDOR_WRITE_PROP calling ECU: change val to %f", propValue.value.floatValues[0]);
			_vendorWriteProp = propValue.value.int32Values[0];
			break;

	}

	return EmulatedVehicleHal::set(propValue);
}

void VendorVehicleHal::onTimer()
{
	
	_vendorWriteProp++;
	
	auto propValue = new VehiclePropValue();
	propValue->prop = VENDOR_WRITE_PROP;
	propValue->timestamp = elapsedRealtimeNano();
	propValue->value.int32Values.resize(1);
	propValue->value.int32Values[0] = _vendorWriteProp;
	
	EmulatedVehicleHal::setPropertyFromVehicle(*propValue);
	
	ALOGI("Making periodic ECU call to update VENDOR_WRITE_PROP to -> %d", _vendorWriteProp);
	
	
}

}  // impl

}  // namespace V2_0
}  // namespace vehicle
}  // namespace automotive
}  // namespace hardware
}  // namespace android
