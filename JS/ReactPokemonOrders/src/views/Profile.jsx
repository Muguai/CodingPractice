import ProfileHeader from "../components/Profile/ProfileHeader";
import ProfileActions from "../components/Profile/ProfileActions";
import ProfileOrderHistory from "../components/Profile/ProfileOrderHistory";
import withAuth from "../hoc/withAuth";
import { useUser } from "../context/UserContext";
import { useEffect } from "react";
import { userById } from "../api/user";
import { STORAGE_KEY_USER } from "../const/storageKeys";
const Profile = () => {
  const { user, setUser } = useUser();

  useEffect(() => {
    const findUser = async () => {
      const [error, latestUser] = await userById(user.id);
      if (error === null) {
        storageSave(STORAGE_KEY_USER, latestUser);
        setUser(latestUser);
      }
    };

    //findUser();
  }, [setUser, user.id]);

  return (
    <>
      <h1>Profile</h1>
      <ProfileHeader username={user.username} />
      <ProfileActions />
      <ProfileOrderHistory orders={user.pokemon} />
    </>
  );
};

export default withAuth(Profile);
