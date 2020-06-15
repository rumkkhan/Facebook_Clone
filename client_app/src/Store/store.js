import React from 'react';
import {combineReducers} from 'redux';
import {ActivityReducer} from '../Store/Activity/';



export default combineReducers({
    activity : ActivityReducer
})