#ifndef android_hardware_automotive_vehicle_V2_0_impl_VendorVehicleHal_H_
#define android_hardware_automotive_vehicle_V2_0_impl_VendorVehicleHal_H_

#include "EmulatedVehicleHal.h"

namespace android {
namespace hardware {
namespace automotive {
namespace vehicle {
namespace V2_0 {

namespace impl {

/** Implementation of VehicleHal that connected to emulator instead of real vehicle network. */
class VendorVehicleHal : public EmulatedVehicleHal {
public:
    VendorVehicleHal(VehiclePropertyStore* propStore, VehicleHalClient* client,
                       EmulatedUserHal* emulatedUserHal = nullptr);

    VehiclePropValuePtr get(const VehiclePropValue& requestedPropValue,
                            StatusCode* outStatus) override;
    StatusCode set(const VehiclePropValue& propValue) override;
private:
	RecurrentTimer mRecurrentTimer;
	void onTimer();
};

}  // impl

}  // namespace V2_0
}  // namespace vehicle
}  // namespace automotive
}  // namespace hardware
}  // namespace android

#endif  // android_hardware_automotive_vehicle_V2_0_impl_EmulatedVehicleHal_H_