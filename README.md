# Toogler
Feature toggle "Toogler"--> controlling features(FeatureButton) based on configuration file/DB.

To configure features:
             * ButtonBlue: 1
             * ButtonGreen: 0
             * ButtonRed: 0

IButtonFeature is a interface with "IsButtonEnabled" prop, which read the configuration and returns a value (true/false). 
If configuration name not exists it will throw a ButtonFeatureNotFoundException.
ButtonFeature is the implementation of IButtonFeature.





