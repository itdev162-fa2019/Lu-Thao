import React, { useState } from 'react';
import axios from 'axios';
import uuid from 'uuid';
import moment from 'moment';
import { useHistory } from 'react-router-dom';
import './styles.css';

const CreatePost = ({onPostData}) => {
    let history = useHistory();
    const [postData, setPostData] = useState({
        title:'',
        body:''
    });
    cost {title,body} = postData;

    const onChange = e => {
        const { name, value } = e.target;

        setPostData({
            ...postData,
            [name]:value
        });
    };
    const creat = async => {
        if(!title || !body){
            console.log('title and body are required');
           }eles {
               const newPost ={
                   id: uuid.v4(),
                   title:title,
                   body:body,
                   date: moment().toISOString()
               };

            try{
                const config = {
                    headers:{
                        'Content-Type':'application/json'
                    }
                };


                const body = JSON.stringify(newPost);
                const res = await axios.post(
                    'http://localhost:5000/api/posts',
                    body,
                    config
                );

                onPostCreated(res.data);
                history.push('/');
            }catch (error) {
                console.error(`Error creating post: ${error.response.data}`);
            }
        }
    };
};