#!/bin/bash
xrandr --output eDP-1 --rotate normal
xinput set-prop '19' 'Coordinate Transformation Matrix' 1 0 0 0 1 0 0 0 1
