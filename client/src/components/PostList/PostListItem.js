import React from 'react';
import { useHistory } from 'react-router-dom';
import slugify from 'slugify';
import style from './styles.css';

const PostListItem = props => {
    const { post, clickPost } = props;
    const history = useHistroy();

    const handleClickPost = post => {
        const slug = slugify(post.title, { lower:true});

        clickPost(post);
        history.push(`/posts/${slug}`);
    }

    return (
        <div className="postListItem" onClick={() => handleClickPost(post)}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
        </div>
    )
}

export default PostListItem;