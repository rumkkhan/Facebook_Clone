import axios from 'axios';


const headers = {
    'Content-Type': 'application/json',
}
export const GET = async(url) => {
    return await axios.get(url,{headers});
} 
export const POST = async(url, body) => {
    return await axios.post(url,body, {headers})
}
export const PUT = async (url,body) => {    
       return  await axios.put(url,body,{headers})
}