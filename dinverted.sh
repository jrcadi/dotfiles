#!/bin/bash
xrandr --output eDP-1 --rotate inverted
xinput set-prop '14' 'Coordinate Transformation Matrix' -1 0 1 0 -1 1 0 0 1
