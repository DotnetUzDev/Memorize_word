PGDMP         5                {            EnglishWord    15.3    15.3 
    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    32927    EnglishWord    DATABASE     �   CREATE DATABASE "EnglishWord" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "EnglishWord";
                postgres    false            �            1259    32929    word    TABLE       CREATE TABLE public.word (
    id integer NOT NULL,
    word text,
    example text,
    describtion text,
    image1 text,
    image2 text,
    image3 text,
    created_at timestamp without time zone,
    updated_at timestamp without time zone,
    translate text
);
    DROP TABLE public.word;
       public         heap    postgres    false            �            1259    32928    word_id_seq    SEQUENCE     �   CREATE SEQUENCE public.word_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.word_id_seq;
       public          postgres    false    215            �           0    0    word_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.word_id_seq OWNED BY public.word.id;
          public          postgres    false    214            e           2604    32932    word id    DEFAULT     b   ALTER TABLE ONLY public.word ALTER COLUMN id SET DEFAULT nextval('public.word_id_seq'::regclass);
 6   ALTER TABLE public.word ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    214    215            �          0    32929    word 
   TABLE DATA           y   COPY public.word (id, word, example, describtion, image1, image2, image3, created_at, updated_at, translate) FROM stdin;
    public          postgres    false    215   �	       �           0    0    word_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.word_id_seq', 44, true);
          public          postgres    false    214            �   �  x���ˎ*9����F��o,�3g1�,zy�V�y Ӑ@����H.���E�,"m˟��#�z�[��Y�a:���p�?�����.f�f(�` �c!��R���&-~�V���.!7�
P���#M�
�4�<��l)�̌�@�ȰD�R�RaEv�2Ir����F�%�%'���.�i�5̕�����64u��m�������n�S�i���B���f�C�n���4lqh�?~�R�ͩo)��?��{ǲ����Jf .�X����18;e�ϊ8�$�3_�g:jg��$��L�褡��xd�tK42O�K��& Œ���k�.t�1W0�m��}�3�g�����p52ڞ�z$^�(��z���
�Xw�f�n	w��,�u������-|m��c�T�dK�ꊆ64��ϩmH8c�ҁHw�?ʨ\B
H<�)sÅQ�+��`�c&�l��^�2e.��<p�����u4) s%Ȣ�
��+�~)�B��0a�=t;�\��y�K���w�j�D\H�%�C���Z�n�54�Ϻ��8������mݫ��g;$��;�Ϥ��m���?v����Rޣό�X��=j&]��ָ	A����(ǉ�L��C;V�A���^L���2�EG�Ě��tː��U�WRr)`�����C��b���tv8��}����
�i�p?j���M���5/���}�v�i/˅�E��8N��G�R�@�ȤDRi���5�%�����8���v	�f\fb�`A+ˬ����5�O�5Y�*�A��k�� �R!f���r�r��1�B��Y�=n���۝O��|==��cOlH�#KR�#ǯ���v��Q�����NY�L��Ȭ�@d�����`cH*�	���q���<�7�-N��#]CS�X�mf��ў�eA�dS)T'����_jX� ����� f�kz��p�:�Sj�%���mݓ-_�!�����W�������v�����?�á�%.X�`�T��j"��QI��r�: G&�{�M>��eJKo�Fô�y��*�*:J��SI2�D����%��r�a��F�]Q���A�"���J�hE���1�#��@F}������)���U;Д~��F�t��E���
�S��1R2�����T��k�#�DK�r�9ـ3��2樄�� 9*�0z+z2��J�6�W �RɅ�V�g�>����z����v�/�A�K�_��=�e=�=��n#\ǧv��B17�,�5�EJBj9s�/�P�e���� ��V�S�TN\I�|����M*VQ��5��%YZg�(�v�X�����8�.������r��~��q�1\��a��n�d#�K��M�y'}��:�r�hy�p�S�ʙ2l�
��!��S�&E���/ӈx��J!7�*�d���L&Q���V2�<i�p#F�|t��L ۥ�Kpg���]�՟��|�7[���     