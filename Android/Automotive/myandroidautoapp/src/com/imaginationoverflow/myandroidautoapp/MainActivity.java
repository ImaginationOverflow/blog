package com.imaginationoverflow.myandroidautoapp;

import androidx.appcompat.app.AppCompatActivity;

import android.car.Car;
import android.car.VehicleAreaType;
import android.car.VehiclePropertyIds;
import android.car.hardware.CarPropertyValue;
import android.car.hardware.property.CarPropertyManager;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.net.DatagramSocket;

public class MainActivity extends AppCompatActivity {

    private TextView _propText;
    private Button _button;
    private Car _carApi;
    private CarPropertyManager _propertyManager;
    private final String TAG = "myandroidautoapp";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _propText = (TextView) findViewById(R.id.prop_text);
        _button = (Button) findViewById(R.id.prop_but);

        _propText.setText("0");

        _button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                buttonClicked();
            }
        });

        initCarApi();
    }

    private void initCarApi() {
        if (_carApi != null && _carApi.isConnected()) {
            _carApi.disconnect();
            _carApi = null;
            _propertyManager = null;
        }
        _carApi = Car.createCar(this, null, Car.CAR_WAIT_TIMEOUT_WAIT_FOREVER,
                (Car car, boolean ready) -> {
                    if (ready) {
                        _propertyManager = (CarPropertyManager) car.getCarManager(android.car.Car.PROPERTY_SERVICE);
                        Log.d(TAG, "Car Api and CarPropertyManager ready");
                        initProperty();
                    }
                });
    }

    private void initProperty() {
        refreshProperty();

        _propertyManager.registerCallback(new CarPropertyManager.CarPropertyEventCallback() {
            @Override
            public void onChangeEvent(CarPropertyValue carPropertyValue) {
                _propText.setText((int) carPropertyValue.getValue());
                Log.d(TAG, "vendorWritePropId value is " + (int) carPropertyValue.getValue());
            }

            @Override
            public void onErrorEvent(int i, int i1) {
            }
        }, VehiclePropertyIds.VENDOR_WRITE_PROP, CarPropertyManager.SENSOR_RATE_NORMAL);
    }

    private void refreshProperty() {
        int val = _propertyManager.getIntProperty(VehiclePropertyIds.VENDOR_WRITE_PROP, VehicleAreaType.VEHICLE_AREA_TYPE_GLOBAL);
        _propText.setText(val + "");
    }

    private void buttonClicked() {
        if (_propertyManager == null)
            return;


        int val = _propertyManager.getIntProperty(VehiclePropertyIds.VENDOR_WRITE_PROP, VehicleAreaType.VEHICLE_AREA_TYPE_GLOBAL);

        _propertyManager.setIntProperty(VehiclePropertyIds.VENDOR_WRITE_PROP, VehicleAreaType.VEHICLE_AREA_TYPE_GLOBAL, val + 1);

        refreshProperty();
    }
}