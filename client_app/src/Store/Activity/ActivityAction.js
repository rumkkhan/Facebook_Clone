import {GET_ALL_ACTIVITY} from './type';
import * as Api from '../../Rest_API/Api_Directory'
import * as HTTP from '../../Rest_API/Https';


export const GetActivities =  () => async dispatch => {
    try{
        let url = Api.GetAllActivities();
        let response =  await HTTP.GET(url);
        
         dispatch( {
            type: GET_ALL_ACTIVITY,
            payload : response.data
        })
    }catch(err)
    {

    }
}
