#!/bin/bash
xrandr --output eDP-1 --rotate right
xinput set-prop '14' 'Coordinate Transformation Matrix' 0 1 0 -1 0 1 0 0 1 
